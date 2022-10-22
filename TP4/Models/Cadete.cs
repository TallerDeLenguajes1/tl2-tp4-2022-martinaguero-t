namespace TP4.Models
{
    public class Cadete {

        private static int autonumerico = 0;
        private int id;
        public string nombre;
        private string direccion;
        private string telefono;

        private List<Pedido> pedidos;

        public int ID { get => id; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public Cadete(string nombre, string direccion, string telefono){
            autonumerico++;
            this.id = autonumerico;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.pedidos = new List<Pedido>();
        }

        /* 
        public void asignarPedido(Pedido pedido){
            this.pedidos.Add(pedido);
        }

        public void borrarPedido(int nroPedido){
    
            Pedido? buscado = this.pedidos.Find(pedido => pedido.getNumero() == nroPedido);

            if(buscado != null && buscado.pedidoRealizado() != true){
                // No elimino un pedido que ya esté realizado.
                this.pedidos.Remove(buscado);
            }

        }

        public Pedido? quitarPedido(int nroPedido){

            Pedido? buscado = this.pedidos.Find(pedido => pedido.getNumero() == nroPedido);

            if(buscado != null && buscado.pedidoRealizado() != true){
                // No elimino un pedido que ya esté realizado.
                this.pedidos.Remove(buscado);
            } else {

                if(buscado == null){
                    Console.WriteLine("El pedido buscado no existe o no está asignado a este cadete.");
                    // logger - si
                } else {
                    Console.WriteLine("No se pueden eliminar pedidos ya realizados por el cadete.");
                }

            }

            return buscado;
        }

        public void entregarPedido(Pedido pedido){
            pedido.marcarComoRealizado();
        }

        public double jornalACobrar(){
            double jornal = pedidos.Where(pedido => pedido.pedidoRealizado() == true).Count() * 300;
            return jornal;
        }

        public int obtenerNumeroPedidosEntregados(){
            int numPedidos = pedidos.Where(pedido => pedido.pedidoRealizado() == true).Count();
            return numPedidos;
        }
        */
        
    }

}