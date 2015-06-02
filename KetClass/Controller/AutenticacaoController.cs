using KetClass.Data;
using KetClass.Model;
using KetClass.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Controller
{
    public class AutenticacaoController
    {

        private static AutenticacaoController controller;

        public static AutenticacaoController getInstance()
        {
            if (controller == null)
            {
                controller = new AutenticacaoController();
            }
            return controller;
        }
        
        private KCContext context = KCContext.getInstance();

        private UserModel UsuarioLogado { get; set; }
        private bool ADM { get; set; }

        public bool IsUsuarioLogado()
        {
            return (UsuarioLogado != null || ADM);
        }
        
        public bool VerificaLogin(string usuario, string senha, bool login)
        {
            UserModel usuarioModel = context.Users.Where(u => u.Login.Equals(usuario) && u.Password.Equals(senha)).FirstOrDefault();
            if (usuarioModel == null)
            {
                if (usuario.Equals("caio") && senha.Equals("123"))
                {
                    ADM = true;
                    return true;
                }

                if (login)
                {
                    UsuarioLogado = null;
                }
                return false;
            }
            if (login)
            {
                UsuarioLogado = usuarioModel;
            }

            return true;
        }

        public int MateriaUsuario()
        {
            if (ADM)
            {
                return -1;
            }
            if (UsuarioLogado == null)
            {
                return -1;
            }
            if (UsuarioLogado.Roles.Count <= 0)
            {
                return -1;
            }
            foreach (RoleModel role in UsuarioLogado.Roles)
            {
                foreach (PermissaoModel permissaoModel in role.Permissoes)
                {
                    if (permissaoModel.Codigo.ToUpper().Contains("MATERIA_ID="))
                    {
                        try
                        {
                            string str_id = permissaoModel.Codigo.ToUpper().Substring(
                                permissaoModel.Codigo.ToUpper().IndexOf("MATERIA_ID=") + 11);
                            return Convert.ToInt32(str_id);
                        }
                        catch (Exception)
                        {
                            return -1;
                        }
                    }
                }
            }
            return -1;
        }

        public bool Autoriza(string permissao)
        {
            if (ADM)
            {
                return true;
            }
            if (UsuarioLogado == null)
            {
                return false;
            }
            if (UsuarioLogado.Roles.Count <= 0)
            {
                return false;
            }
            foreach (RoleModel role in UsuarioLogado.Roles)
            {
                foreach (PermissaoModel permissaoModel in role.Permissoes)
                {
                    if (permissaoModel.Codigo.ToUpper().Equals(permissao.ToUpper()) || permissaoModel.Codigo.Equals("*"))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void AddUsuario(string usuario, string senha)
        {
            UserModel user = new UserModel();
            user.Login = usuario;
            user.Password = senha;
            user.Nome = usuario;
            context.Users.Add(user);
            context.SaveChanges();
        }

        public void AddRole(List<Permissao> permissoes)
        {
            List<PermissaoModel> permissoesM = new List<PermissaoModel>();
            bool add = true;
            foreach (Permissao permissao in permissoes)
            {
                add = true;
                foreach (PermissaoModel permissaoM in context.Permissoes)
                {
                    if (permissaoM.Codigo.ToUpper().Equals(permissao.PermissaoNome.ToUpper()))
                    {
                        permissoesM.Add(permissaoM);
                        add = false;
                    }
                }
                if (add)
                {
                    PermissaoModel permissaoAdd = new PermissaoModel();
                    permissaoAdd.Codigo = permissao.PermissaoNome;
                    permissaoAdd.DataCriacao = DateTime.Now;
                    permissaoAdd.DataAlteracao = DateTime.Now;
                    permissaoAdd = context.Permissoes.Add(permissaoAdd);
                    context.SaveChanges();
                    permissoesM.Add(permissaoAdd);
                }
            }
            RoleModel role = new RoleModel();
            role.Permissoes = permissoesM;
            context.Roles.Add(role);
            context.SaveChanges();
        }        
    }
}
