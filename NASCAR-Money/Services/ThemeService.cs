namespace NASCAR_Money.Services
{
    public class ThemeService
    {
        public bool IsDarkMode { get; set; }
        public event Action OnChange;

        public void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}
