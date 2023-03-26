namespace Console_Csharp_trainee
{
    public class Clientes
    {
        public string? nomeCompleto { get; set; }

        public string? rg { get; set; }

        public string? email { get; set; }

        public int idade { get; set; }

        public int pedido { get; set ; }

        //public string _x = "---";
        public TiposPedidoEnum tipoPedido { get; set; }
        public TiposPedidoEnum descricaoPedido { 
            get => tipoPedido; 
            set {
                if(tipoPedido == TiposPedidoEnum.WebSite)
                {
                    descricaoPedido = TiposPedidoEnum.WebSite;
                }
                else{
                    descricaoPedido = TiposPedidoEnum.App;
                }
            } 
            }
        //public string nomePedido { get; set; }

        public double preco { get; set; }   

    }
}