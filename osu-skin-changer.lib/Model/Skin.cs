using System.ComponentModel.DataAnnotations;

namespace osu_skin_changer.lib.Model
{
    public class Skin
    {
        [Required(ErrorMessage = "Name is empty.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Author is empty.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Profile is empty.")]
        public string Profile { get; set; }

        [Required(ErrorMessage = "Version is empty.")]
        public string Version { get; set; }

        public FileCollection<Sound> InterfaceSounds { get; set; }
        public FileCollection<Sound> SoftHitsounds { get; set; }
        public FileCollection<Sound> NormalHitsounds { get; set; }
        public FileCollection<Sound> DrumHitsounds { get; set; }
        public FileCollection<Sound> NightcoreHitsounds { get; set; }
        public FileCollection<Sound> SpinnerSounds { get; set; }

        public FileCollection<Image> Cursor { get; set; }
        public FileCollection<Image> FollowPoint { get; set; }
        public FileCollection<Image> Interface { get; set; }
        public FileCollection<Image> Miss { get; set; }
        public FileCollection<Image> Hit50 { get; set; }
        public FileCollection<Image> Hit100 { get; set; }
        public FileCollection<Image> Hit300 { get; set; }
        public FileCollection<Image> HitCircle { get; set; }
        public FileCollection<Image> RankingPanelHits { get; set; }
        public FileCollection<Image> RankingPanelRanks { get; set; }
        public FileCollection<Image> Ranks { get; set; }
        public FileCollection<Image> InGameInterface { get; set; }
        public FileCollection<Image> RankingPanel { get; set; }
        public FileCollection<Image> Score { get; set; }
        public FileCollection<Image> Default { get; set; }
        public FileCollection<Image> Combo { get; set; }
        public FileCollection<Image> ModIcons { get; set; }
        public FileCollection<Image> Spinner { get; set; }
        public FileCollection<Image> WelcomeText { get; set; }

        public Settings Settings { get; set; }

        public Skin() { }
    }
}