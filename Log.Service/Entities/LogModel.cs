using System;

namespace Log.Service.Entities
{
    public class LogModel
    {
        //
        // Summary:
        //     Gets the text associated with the System.Diagnostics.EventLogEntry.CategoryNumber
        //     property for this entry.
        //
        // Returns:
        //     The application-specific category text.
        //
        // Exceptions:
        //   T:System.Exception:
        //     The space could not be allocated for one of the insertion strings associated
        //     with the category.
        public string Category { get; set; }
        //
        // Summary:
        //     Gets the event type of this entry.
        //
        // Returns:
        //     The event type that is associated with the entry in the event log.
        public string Type { get; set; }
        //
        // Summary:
        //     Gets the resource identifier that designates the message text of the event entry.
        //
        // Returns:
        //     A resource identifier that corresponds to a string definition in the message
        //     resource file of the event source.
        public long InstanceId { get; set; }
        //
        // Summary:
        //     Gets the name of the computer on which this entry was generated.
        //
        // Returns:
        //     The name of the computer that contains the event log.
        public string MachineName { get; set; }
        //
        // Summary:
        //     Gets the localized message associated with this event entry.
        //
        // Returns:
        //     The formatted, localized text for the message. This includes associated replacement
        //     strings.
        //
        // Exceptions:
        //   T:System.Exception:
        //     The space could not be allocated for one of the insertion strings associated
        //     with the message.
        public string Message { get; set; }
        //
        // Summary:
        //     Gets the name of the application that generated this event.
        //
        // Returns:
        //     The name registered with the event log as the source of this event.
        public string Source { get; set; }
        //
        // Summary:
        //     Gets the local time at which this event was generated.
        //
        // Returns:
        //     The local time at which this event was generated.
        public string TimeGenerated { get; set; }
        //
        // Summary:
        //     Gets the local time at which this event was written to the log.
        //
        // Returns:
        //     The local time at which this event was written to the log.
        public string TimeWritten { get; set; }
        //
        // Summary:
        //     Gets the name of the user who is responsible for this event.
        //
        // Returns:
        //     The security identifier (SID) that uniquely identifies a user or group.
        //
        // Exceptions:
        //   T:System.SystemException:
        //     Account information could not be obtained for the user's SID.
        public string UserName { get; set; }
    }
}