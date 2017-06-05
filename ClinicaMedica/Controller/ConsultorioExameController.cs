﻿using ClinicaMedica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedica.Controller
{
    class ConsultorioExameController
    {
        private DataModelContainer db = new DataModelContainer();

        public void Insert(ConsultorioExame conex)
        {

            var erros = Validacao.Validar(conex);


            if (erros.Count() == 0)
            {
                try
                {
                    db.TB_ConsultorioExame.Add(conex);
                    db.SaveChanges();
                   // MessageBox.Show("Consultório cadastrado com sucesso!");
                }

                catch (Exception e)
                {
                //    MessageBox.Show("Não foi possível cadastrar o consultório!\n" + e.Message);
                }
                //  CadastroCargo.ActiveForm.Close();

            }
            else
            {
                foreach (var e in erros)
                    MessageBox.Show(e.ToString());
            }

        }
    }
}
