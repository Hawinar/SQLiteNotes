using System;
using System.Collections.Generic;

namespace SQLiteNotes;

public partial class Note
{
    public long Id { get; set; }

    public string? Title { get; set; }

    public string? Text { get; set; }

    public string? DateLastChange { get; set; }

    public string? FontFamily { get; set; }

    public long? FontSize { get; set; }
}
