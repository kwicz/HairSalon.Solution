using System.Collections.Generic;
using System;

namespace EauClairesSalon.Models
{
public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string HireDate { get; set; }
    public string Speciality { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}