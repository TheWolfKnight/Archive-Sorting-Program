using Abstraction.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction.Models
{
    public class Anime
    {
        public string Title { get; set; } = null;
        public string Description { get; set; } = null;

        public WatchStatus WatchStatus { get; set; } = WatchStatus.UNCHANGED;
        public ReleaseStatus ReleaseStatus { get; set; } = ReleaseStatus.UNCHANGED;

        private int[] _progress = null;

        public string Progress
        {
            get
            {
                return _progress != null ? string.Join(", ", _progress) : "";
            }
            set
            {
                int[] tmp = value.Split(',').Select(item => int.Parse(item.Trim())).ToArray();

                if (tmp.Length != 4)
                    throw new ArgumentOutOfRangeException();
                _progress = tmp;
            }
        }

        private string[] _tags = null;

        public string Tags
        {
            get
            {
                return _tags != null ? string.Join(", ", _tags) : "";
            }
            set
            {
                string[] tmp = value.Split(',').Select(item => item.Trim()).ToArray();
                _tags = tmp;
            }
        }

        public Anime()
        {
        }

        public Anime(DataGridViewRow data)
        {

        }
    }
}
