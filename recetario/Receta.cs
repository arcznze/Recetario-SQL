using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace recetario
{
    internal class Receta
    {

    }

    internal class Ingredientes
    {

    }

    internal class Recetario : recetarioBaseVisitor<object>
    {
        public override object VisitIngredientes([NotNull] recetarioParser.IngredientesContext context)
        {
            return base.VisitIngredientes(context);
        }

        public override object VisitReceta([NotNull] recetarioParser.RecetaContext context)
        {
            return base.VisitReceta(context);
        }
    }
}
