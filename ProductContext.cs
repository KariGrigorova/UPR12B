using System;

public class ProductContext:DbContext
{

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=.; Integrated Security=true; Database=ProductDb");
	}
	public DbSet<Product> Products { get; set; }
}
