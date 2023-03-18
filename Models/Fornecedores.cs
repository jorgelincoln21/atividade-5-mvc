namespace LHPets.Models;


  public class Fornecedores
  {
    public int Id { get; set; }
    
    public string? Nome { get; set; }

    public string? Cnpj { get; set; }

    public string? Email { get; set; }

    
      public Fornecedores(int Id, string Nome, string Cnpj, string Email )
    {
        this.Id = Id;
        this.Nome = Nome;
        this.Cnpj = Cnpj;
        this.Email = Email;
    }
  }