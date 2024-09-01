using Microsoft.EntityFrameworkCore;

namespace DataAccess;

// Это основной класс контекста базы данных, который управляет сущностями и их состоянием.
// Он наследует от `DbContext`, что позволяет использовать функциональность Entity Framework для работы с базой данных.
// Конструктор класса, который принимает параметры конфигурации для контекста базы данных.
public class AppContext(DbContextOptions<AppContext> options) : DbContext(options)
{
    // Этот DbSet свойство представляет таблицу "Notes" в базе данных.
    // Оно позволяет выполнять CRUD операции (Create, Read, Update, Delete) с записями в этой таблице.
    public DbSet<Note> Notes { get; set; }
    
    // Метод, который настраивает модель.
    // Здесь мы определяем конфигурацию для сущности Note.
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Указываем, что свойство Id является первичным ключом для сущности Note.
        modelBuilder.Entity<Note>().HasKey(x => x.Id);
        // Ограничиваем длину текста в свойстве Text до 140 символов.
        modelBuilder.Entity<Note>().Property(x => x.Text).HasMaxLength(140);
        base.OnModelCreating(modelBuilder);
    }
}