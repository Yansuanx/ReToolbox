namespace ReToolbox.Models
{
    // One line in the install log. A Normal entry is appended as a new line;
    // a Progress entry (a winget download bar redraw, a spinner frame, ...)
    // updates the most recent line in place, mirroring how the source terminal
    // redraws a single status line instead of scrolling it.
    public sealed class LogEntry
    {
        public LogEntryKind Kind { get; init; }

        public string Text { get; init; } = string.Empty;

        public static LogEntry Normal(string text) => new() { Kind = LogEntryKind.Normal, Text = text };

        public static LogEntry Progress(string text) => new() { Kind = LogEntryKind.Progress, Text = text };
    }

    public enum LogEntryKind
    {
        Normal,
        Progress
    }
}
