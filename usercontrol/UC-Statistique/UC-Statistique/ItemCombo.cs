using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_Statistique
{
    class ItemCombo
    {
    public ItemCombo(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }

    public int Id { get; set; }
    public string Nom { get; set; }

    public override string ToString()
    {
        return Nom;
    }
        }
}
