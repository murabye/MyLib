using System;

namespace MyLib
{
    public class Name
    {
        static Random r = new Random();
        #region man
        private static string[] manSurnames = {"Иванов", "Петров", "Сидоров", "Кузнецов",
            "Соловьев", "Липин", "Коковин", "Ермолаев", "Белкин", "Кокоулин", "Исламов",
            "Буляков", "Попов", "Буров", "Власов", "Вяткин", "Боталов", "Кагиров", "Шабатин" };
        private static string[] manNames = {"Ваня", "Петя", "Вова", "Максим","Слава","Егор","Костя","Руслан",
            "Артем","Артур","Ашот","Акакий","Олег","Федор","Данил","Вася","Витя","Гена","Гоша",
            "Женя","Саша","Игорь","Коля", "Паша", "Руслан", "Рустам", "Эдик", "Ярик" };
        private static string[] manParentnames = {"Иванович", "Петрович", "Владимирович",
            "Максимович","Владиславович","Егорович","Константинович","Русланович",
            "Артемович","Артурович","Ашотович","Акакиевич","Олегович","Федорович","Данилович",
            "Василиевич","Витальевич","Геннадьевич","Георгович", "Евгеньевич","Александрович",
            "Игоревич","Андреевич", "Павлович", "Русланович", "Рустамович", "Эдуардович", "Ярославович"};
        #endregion
        #region woman
        private static string[] womanSurnames = {"Иванова", "Петрова", "Сидорова", "Кузнецова",
            "Соловьева", "Липина", "Коковина", "Ермолаева", "Белкина", "Кокоулина", "Исламова",
            "Булякова", "Попова", "Бурова", "Власова", "Вяткина", "Боталова", "Кагирова", "Шабатина" };
        private static string[] womanNames = {"Ваня", "Петя", "Вова", "Максим","Слава","Егор","Костя","Руслан",
            "Артем","Артур","Ашот","Акакий","Олег","Федор","Данил","Вася","Витя","Гена","Гоша",
            "Женя","Саша","Игорь","Коля", "Паша", "Руслан", "Рустам", "Эдик", "Ярик" };
        private static string[] womanParentnames = {"Иванова", "Петрова", "Владимировна",
            "Максимовна","Владиславовна","Егоровна","Константиновна","Руслановна",
            "Артемовна","Артуровна","Ашотовна","Акакиева","Олеговна","Федоровна","Даниловна",
            "Василиевовна","Витальевна","Геннадьевна","Георгиева", "Евгеньевна","Александровна",
            "Игоревна","Андреевна", "Павлова", "Рустамович", "Эдуардовна", "Ярославовна"};
        #endregion

        private bool male { get; set; }
        private string name { get; set; }
        private string surname { get; set; }
        private string parentname { get; set; }

        public Name()
        {
            male = r.Next(0, 3) > 0;
            if (male)
            {
                name = manNames[r.Next(0, manNames.Length)];
                surname = manSurnames[r.Next(0, manNames.Length)];
                parentname = manParentnames[r.Next(0, manNames.Length)];
            }
            else
            {
                name = womanNames[r.Next(0, manNames.Length)];
                surname = womanSurnames[r.Next(0, manNames.Length)];
                parentname = womanParentnames[r.Next(0, manNames.Length)];
            }
        }
        public Name(bool male)
        {
            this.male = male;

            if (male)
            {
                name = manNames[r.Next(0, manNames.Length)];
                surname = manSurnames[r.Next(0, manNames.Length)];
                parentname = manParentnames[r.Next(0, manNames.Length)];
            }
            else
            {
                name = womanNames[r.Next(0, manNames.Length)];
                surname = womanSurnames[r.Next(0, manNames.Length)];
                parentname = womanParentnames[r.Next(0, manNames.Length)];
            }
        }
        public Name(bool male, string name, string surname, string parentname)
        {
            this.male = male;
            this.name = name;
            this.surname = surname;
            this.parentname = parentname;
        }

        public override string ToString()
        {
            return surname + name + parentname;
        }
    }
}
