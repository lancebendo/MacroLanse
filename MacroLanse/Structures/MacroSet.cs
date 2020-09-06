using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroLanse.Structures
{
    public class MacroSet
    {

        public string Name { get; set; }

        public List<Macro> Macros { get; set; } = new List<Macro>();

        //dito lagay yung add, switch(up or down) at delete macro.
        //remove position sa form
        public void InsertMacro(Macro macro)
        {
            int? lastPosition = Macros?.OrderByDescending(m => m.Position).FirstOrDefault()?.Position;

            if (lastPosition == null) macro.Position = 1;
            else macro.Position = lastPosition.Value + 1;

            Macros.Add(macro);
        }

        public void SwitchMacroUp(Macro macro)
        {
            if (macro == null || macro.Position <= 1) return;

            int nextPosition = macro.Position - 1;

            Macro macroToSwitch = Macros.Where(m => m.Position == nextPosition).FirstOrDefault();
            macroToSwitch.Position = macro.Position;
            macro.Position = nextPosition;

            //validate muna kung nasa list
        }

        public void SwitchMacroDown(Macro macro)
        {
            if (macro == null || macro.Position < 1 || macro.Position == Macros.Count) return;

            int nextPosition = macro.Position + 1;

            Macro macroToSwitch = Macros.Where(m => m.Position == nextPosition).FirstOrDefault();
            macroToSwitch.Position = macro.Position;
            macro.Position = nextPosition;
        }
    }
}
