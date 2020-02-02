namespace Platzi_ASP_NET_CORE.Models
{ 
    public interface ILugar
    {
       string Dirección { get; set; }

       void LimpiarLugar();

    }
}