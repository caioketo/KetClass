﻿using KetClass.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetClass.Model
{
    public class NotaModel : BaseEntity
    {
        public int AlunoId { get; set; }
        [ForeignKey("AlunoId")]
        public virtual AlunoModel Aluno { get; set; }

        public int TurmaId { get; set; }
        [ForeignKey("TurmaId")]
        public virtual TurmaModel Turma { get; set; }

        [NotMapped]
        public string TurmaDescricao
        {
            get
            {
                if (Turma == null)
                {
                    return "";
                }
                return Turma.Display;
            }
        }

        public int DisciplinaId { get; set; }
        [ForeignKey("DisciplinaId")]
        public virtual DisciplinaModel Disciplina { get; set; }

        [NotMapped]
        public string DisciplinaDesc
        {
            get
            {
                if (Disciplina == null)
                {
                    return "";
                }
                return Disciplina.Descricao;
            }
        }

        public int Numero { get; set; }
        public double Nota { get; set; }
        public int Faltas { get; set; }
        public int AulasDadas { get; set; }
        public bool Recupercao { get; set; }
        public int Trimestre { get; set; }

        public NotaModel() { }
        public NotaModel(NotaModel notaC)
        {
            this.AlunoId = notaC.AlunoId;
            this.AulasDadas = notaC.AulasDadas;
            this.DisciplinaId = notaC.DisciplinaId;
            this.Faltas = notaC.Faltas;
            this.Numero = notaC.Numero;
            this.Trimestre = notaC.Trimestre;
            this.TurmaId = notaC.TurmaId;
            this.Recupercao = notaC.Recupercao;
            this.Nota = notaC.Nota;
        }
    }
}
