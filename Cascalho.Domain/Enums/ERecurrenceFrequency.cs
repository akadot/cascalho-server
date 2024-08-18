namespace Cascalho.Domain.Enums;

public enum ERecurrenceFrequency
{
    Daily = 0,
    Weekly = 1,
    Monthly = 2,
    Yearly = 3
}

/*
HANDLE FREQUENCY EXAMPLE 
public void GenerateNextReminder(Reminder reminder)
{
    if (!reminder.IsRecurring || !reminder.RecurrenceFrequency.HasValue)
        return;

    DateTime nextDate = reminder.ScheduledAt;

    switch (reminder.RecurrenceFrequency)
    {
        case ERecurrenceFrequency.Daily:
            nextDate = reminder.ScheduledAt.AddDays(1);
            break;
        case ERecurrenceFrequency.Weekly:
            nextDate = reminder.ScheduledAt.AddWeeks(1);
            break;
        case ERecurrenceFrequency.Monthly:
            nextDate = reminder.ScheduledAt.AddMonths(1);
            break;
        case ERecurrenceFrequency.Yearly:
            nextDate = reminder.ScheduledAt.AddYears(1);
            break;
    }

    if (reminder.RecurrenceEndDate.HasValue && nextDate > reminder.RecurrenceEndDate.Value)
        return; // Não gera mais lembretes após a data final de recorrência

    var newReminder = new Reminder
    {
        ScheduledAt = nextDate,
        Amount = reminder.Amount,
        UserId = reminder.UserId,
        RecurrenceFrequency = reminder.RecurrenceFrequency,
        RecurrenceEndDate = reminder.RecurrenceEndDate,
        IsRecurring = reminder.IsRecurring
    };

    // Salve o novo lembrete no banco de dados
}
*/
