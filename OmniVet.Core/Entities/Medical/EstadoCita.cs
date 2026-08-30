using System;

namespace OmniVet.Core.Entities.Medical
{
    public abstract class EstadoCita
    {
        public abstract string Nombre { get; }
        public abstract string ColorUI { get; }
        public abstract bool PermiteCancelar { get; }
    }

    public class CitaConfirmada : EstadoCita
    {
        public override string Nombre => "Confirmada";
        public override string ColorUI => "Verde";
        public override bool PermiteCancelar => true;
    }

    public class CitaEnEspera : EstadoCita
    {
        public override string Nombre => "En Espera";
        public override string ColorUI => "Amarillo";
        public override bool PermiteCancelar => true;
    }

    public class CitaEnConsulta : EstadoCita
    {
        public override string Nombre => "En Consulta";
        public override string ColorUI => "Azul";
        public override bool PermiteCancelar => false;
    }

    public class CitaFinalizada : EstadoCita
    {
        public override string Nombre => "Finalizada";
        public override string ColorUI => "Gris";
        public override bool PermiteCancelar => false;
    }

    public class CitaCancelada : EstadoCita
    {
        public override string Nombre => "Cancelada";
        public override string ColorUI => "Rojo";
        public override bool PermiteCancelar => false;
    }
}