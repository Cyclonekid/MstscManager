namespace MstscManager {
    internal static class Program {
        public static EventWaitHandle ProgramStarted;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            // ���Դ���һ�������¼�
            bool createNew;
            ProgramStarted = new EventWaitHandle(false, EventResetMode.AutoReset, "MstscManager", out createNew);

            // ����������¼��Ѿ�����(������ǰһ������ʵ��)�����¼�֪ͨ���˳�
            if (!createNew) {
                ProgramStarted.Set();
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FMain());
        }
    }
}