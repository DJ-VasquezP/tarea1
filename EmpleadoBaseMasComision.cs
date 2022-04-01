﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleado
{
    public class EmpleadoBaseMasComision : EmpleadoXComision
    {
        private decimal salarioBase;

        public EmpleadoBaseMasComision (string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario) : base (nombre, apellido, nss, ventas, tarifa)
        {
            salarioBase = salario;
        }

        public decimal SalarioBase
        { get { return salarioBase; } set { salarioBase = (value >= 0)? value : 0; } }

        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}; {2}: {3:C}", "SALARIO BASE ", base.ToString(), "+ SALARIO BASE", SalarioBase);
        }
    }
}
