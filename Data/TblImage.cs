using System;
using System.Collections.Generic;

namespace ImageGallery.Data;

public partial class TblImage
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string ImageUrl { get; set; } = null!;
}
