using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Abstraction.Enumerators;
using Abstraction.Models;

namespace Frontend.Views
{
    public partial class AnimeView : Form
    {

        private Anime _currentAnime = null;
        private bool _newAnime = false;

        public AnimeView(Anime anime)
        {
            InitializeComponent();

            _currentAnime = anime;
            if (_currentAnime == null) _newAnime = true;
        }

        private void AnimeView_Load(object sender, EventArgs e)
        {
            IList<string> statusDescriptions =
                ((int[])Enum.GetValues(typeof(WatchStatus)))
                            .Select(item => Enumerators.GetEnumDescription((WatchStatus)item))
                            .ToList();
            cmb_WatchStatus.DataSource = statusDescriptions;

            statusDescriptions =
                ((int[])Enum.GetValues(typeof(ReleaseStatus)))
                            .Select(item => Enumerators.GetEnumDescription((ReleaseStatus)item))
                            .ToList();
            cmb_ReleaseStatus.DataSource = statusDescriptions;

            if (!_newAnime)
            {
                btn_Delete.Visible = true;
                btn_Delete.Enabled = true;

                SetPageText();
                ShowAnimeInfo();
            }
            else
            {
                this.Text = "New Anime";
            }
        }

        private void SetPageText()
        {
            string title = _currentAnime.Title.Length < 20 ? _currentAnime.Title : _currentAnime.Title.Substring(0, 15) + "...";
            this.Text = title;
        }

        private void ShowAnimeInfo()
        {
            txb_Title.Text = _currentAnime.Title;
            rtb_Description.Text = _currentAnime.Description;
            txb_Tags.Text = _currentAnime.Tags;

            string progress = _currentAnime.Progress;
            if (progress != null)
            {
                IEnumerable<string> progressSplit = progress.Split(',').Select(item => item.Trim());
                txb_EpisodeCount.Text = progressSplit.ElementAt(0);
                txb_EpisodeSeen.Text  = progressSplit.ElementAt(1);
                txb_SeasonCount.Text  = progressSplit.ElementAt(2);
                txb_SeasonSeen.Text   = progressSplit.ElementAt(3);
            
            }

            cmb_WatchStatus.SelectedIndex =
                cmb_WatchStatus.Items.IndexOf(Enumerators.GetEnumDescription(_currentAnime.WatchStatus));
            cmb_ReleaseStatus.SelectedIndex =
                cmb_ReleaseStatus.Items.IndexOf(Enumerators.GetEnumDescription(_currentAnime.ReleaseStatus));
        }

        private Anime GatherAnimeInfo()
        {
            Anime result = new Anime();

            return result;
        }
    }
}
