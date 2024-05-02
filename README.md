PROYECTO EN DESARROLLO
EN SINTASIS LO QUE SE DEBE OPTENER ES QUE SE PUEDA AGRGAR INGREDIENTES, RECETA, CANTIDAD Y SE GUARDE EN UNA LISTA Y SE MUESTRE PARA EL USUARIO FINAL







Dictionary<string, string> receta3 = new Dictionary<string, string>();
private void btnNuevaRe_Click(object sender, EventArgs e)
{
    string nombreReceta = txtNombre.Text;

    string ingredienteReceta = txtIngredientes.Text;

    List<Dictionary<string, object>> listaDeIngredientes = new List<Dictionary<string, object>>();


    Dictionary<string, object> Ingrediente1 = new Dictionary<string, object>();



    List<Dictionary<string, object>> listaDeRecetas = new List<Dictionary<string, object>>();


    Dictionary<string, object> Receta1 = new Dictionary<string, object>();

    if (nombreReceta != "" && ingredienteReceta != "")
    {


        var nombre = txtNombre.Text;
        int cantidad = Convert.ToInt32(nudCantidad.Value);

        Receta1.Add(nombre, cantidad);

















        /*
        List<Dictionary<string, string>> receta = new List<Dictionary<string, string>>();



        receta.Add(nombreReceta);
        receta.Add(ingredienteReceta);


        receta3.Add("Nombre", nombreReceta);
        receta3.Add("ingredientes",ingredienteReceta);
        printdgvLista();
        */
    }
