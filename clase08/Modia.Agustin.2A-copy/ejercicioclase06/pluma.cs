using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasee05
{
  class pluma
  {
    #region atributos

    private string marca;
    private int cantidad;
    private tinta tinta;

    #endregion


    #region contructores
        
    public pluma()
    {
      this.cantidad = 1;
      this.marca = "sin marca";
      this.tinta = null;
    }
    public pluma(int a) : this()
    {
      this.cantidad = a;

    }

    public pluma(int a, string b) : this(a)
    {
      this.marca = b;

    }

    public pluma(int a, string b, tinta c) : this(a, b)
    {
      this.tinta = c;

    }

    #endregion

    #region metodos

    private string mostrar()
    {
      string retorno = "";
      
     
      if ((object) this.tinta == null)
      {
        Console.WriteLine("error no se ha cargado la tinta vuelva a intentarlo");

      }

        if ((object) this.tinta != null)
        {

          retorno = this.marca + "--" + this.cantidad + "--" + tinta.Mostrar(this.tinta);
        
      }

      return retorno;
    }




    #endregion



    #region sobrecargas


    public static implicit operator string(pluma n)
    {

      return n.mostrar();

    }

    public static bool operator ==(pluma a, tinta b)
    {
      bool retorno = false;

      if ((object)a.tinta == null)

      {
        if (a.tinta == b)
        {
          retorno = true;
        }
      }
      
      return retorno;
    }

    public static bool operator !=(pluma a, tinta b)
    {




      return !(a == b);
    }

    public static pluma operator +(pluma a, tinta b)

    {

      if(a.tinta == b && a.cantidad <=99)
      {

        a.cantidad += 10;

       
        
      }

            if (a.cantidad == 100)
            {
                
                Console.WriteLine("se ha llegado al limite de cantidad");

            }
            return a;
    }

    public static pluma operator -(pluma a, tinta b)

    {

      if (a.tinta == b && a.cantidad >=10 && a.cantidad <=100)
      {

        a.cantidad -= 10;

      }
      return a;
    }
    #endregion



  }
}
