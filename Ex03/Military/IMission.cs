namespace Military
{
    interface IMission
    {
        public string Name { get; set; }
        public string State { get; set; }

        void CompleteMission();
    }
}
