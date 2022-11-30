using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;

namespace recetario
{
    //public class recipes
    //{
    //    public int id;
    //    public string name = "";
    //    public int portions;
    //    public int? prep_time; //null
    //    public string? prep_time_unit = ""; //null
    //    public int? cook_time; //null
    //    public string? cook_time_unit = ""; //null
    //    public int calories;
    //}

    public class ingredient_units
    {
        public int id;
        public string name = "";
    }

    public class cooking_steps
    {
        public int id;
        public int recipe_id;
        public int step_number;
        public string description = "";
    }

    internal class recipes
    {
        public recipes(int id, string name, int portions, int? prep_time, string? prep_time_unit, int? cook_time, 
            string? cook_time_unit, int calories) => 
            (this.id, this.name, this.portions, this.prep_time, this.prep_time_unit, this.cook_time, this.cook_time_unit, this.calories) = (id, name, portions, prep_time, prep_time_unit, cook_time, cook_time_unit, calories);
       
        public int id;
        public string name = "";
        public int portions;
        public int? prep_time; //null
        public string? prep_time_unit = ""; //null
        public int? cook_time; //null
        public string? cook_time_unit = ""; //null
        public int calories;

        public string ObtenerInsert()
        {
            return $"INSERT INTO recipes (id, name, portions, prep_time, prep_time_unit, cook_time, cook_time_unit, calories) " +
                $"VALUES ({this.id},{this.name}, {this.portions}, {this.prep_time}, {this.prep_time_unit}, {this.cook_time}, {this.cook_time}, {this.cook_time_unit}, {this.calories})";
        }
    }

    internal class ingredients
    {
        public ingredients(int id, string name, float quantity) => (this.id, this.name, this.quantity) = (id, name, quantity);
        public int id;
        public int? recipe_id;
        public string name = "";
        public float quantity;
        public int? unit_id; //null

        public string ObtenerInsert()
        {
            return $"INSERT INTO ingredients (id, recipe_id, name, quantity, unit_id) " +
                $"VALUES ({this.id}, {this.recipe_id},{this.name}, {this.quantity}, {this.unit_id})";
        }
    }

    internal class Recetario : recetarioBaseVisitor<object>
    {
        public override object VisitEntry([NotNull] recetarioParser.EntryContext context)
        {
            string nombre = ((string)Visit(context.receta()));
            return new Object();
        }

        public override object VisitIngredientes([NotNull] recetarioParser.IngredientesContext context)
        {
            return base.VisitIngredientes(context);
        }

        public override object VisitReceta([NotNull] recetarioParser.RecetaContext context)
        {
            return context.TEXT().GetText();
        }
    }
}
