namespace Back
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public string numeroTarjeta { get; set; }
        public float limiteCredito { get; set; }
        public float saldoActual { get; set; }
        public Cliente clienteTC { get; set; }
        public EstadoTarjeta estado { get; set; } // Agregar la propiedad de estado

        public enum EstadoTarjeta
        {
            Activa,
            Pausada,
            Bloqueada
        }
    }

}