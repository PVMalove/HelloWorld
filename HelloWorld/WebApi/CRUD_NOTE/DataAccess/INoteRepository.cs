namespace DataAccess;


//Этот код определяет интерфейс INoteRepository, который представляет собой абстракцию для работы с заметками (notes).
public interface INoteRepository
{
    //Note note: объект типа Note, который нужно создать.
    //CancellationToken cancellationToken: опциональный параметр по умолчанию, который позволяет прервать асинхронную операцию.
    Task CreateAsync(Note note, CancellationToken cancellationToken = default);
    Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
    Task UpdateAsync(Note note, CancellationToken cancellationToken = default);
    Task DeleteAsync(Note note, CancellationToken cancellationToken = default);
}

//  Паттерн репозиторий:
//  Абстракция данных: Интерфейс предоставляет единообразный способ взаимодействия с данными БД, независимо от конкретной реализации хранения данных.
//  Инкупсуляция: Позволяет легко изменять реализацию репозитория без влияния на остальную часть приложения.
//  Разделение ответственности: Бизнес-логика может работать с этим интерфейсом, не зная деталей реализации сохранения данных.
//  Гибкость: Разработчики могут легко заменить реализацию репозитория без изменения остальной части приложения.
//  Тестирование: Легко создавать моки или стабы для этого интерфейса при написании тестов.