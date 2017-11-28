using System;
using System.Collections.Generic;
using System.Linq;
using WinformsSandbox.Models.Interfaces;

namespace WinformsSandbox.Models.Classes
{
    public class Group : List<IPerson>, IGroup
    {
        #region IGroup Implementation

        public string GroupName { get; set; }

        #endregion


        #region constructor

        public Group(string groupName)
        {
            GroupName = groupName;
        }

        #endregion


        #region Random Group Generation

        public static Group GetRandomGroup(int numberOfPeople)
        {
            numberOfPeople = Math.Max(0, numberOfPeople);
            numberOfPeople = Math.Min(RandomPersonSourceList.Count, numberOfPeople);
            Group result = new Group("{Random Group: " + Guid.NewGuid() + "}");
            result.AddRange((from Person p in RandomPersonSourceList orderby Guid.NewGuid() select p).Take(numberOfPeople));
            return result;
        }

        private static readonly List<Person> RandomPersonSourceList = new List<Person>
        {
            new Person(1, "Leonor Halberg"),
            new Person(2, "Emil Hardin"),
            new Person(3, "Fredda Tardif"),
            new Person(4, "Regenia Kearley"),
            new Person(5, "Antonietta Batie"),
            new Person(6, "Rikki Melnyk"),
            new Person(7, "Claire Younger"),
            new Person(8, "Mindy Smale"),
            new Person(9, "Fredricka Vining"),
            new Person(10, "Maribeth Corum"),
            new Person(11, "Dagmar Paulson"),
            new Person(12, "Ariane Rexroat"),
            new Person(13, "Kristyn Drakeford"),
            new Person(14, "Susan Debose"),
            new Person(15, "Marisol Felter"),
            new Person(16, "Lenore Costner"),
            new Person(17, "Mitch Tremblay"),
            new Person(18, "Madie Penn"),
            new Person(19, "Eduardo Gloster"),
            new Person(20, "Ardella Bongiorno"),
            new Person(21, "Gertude Sherburne"),
            new Person(22, "Basilia Leger"),
            new Person(23, "Brianna Fleener"),
            new Person(24, "Kristian Langlois"),
            new Person(25, "Billi Torgerson"),
            new Person(26, "Tawnya Berenbaum"),
            new Person(27, "Ma Fritze"),
            new Person(28, "Lilly Ketchum"),
            new Person(29, "Lourie Snook"),
            new Person(30, "Brice Spece"),
            new Person(31, "Zenia Wilke"),
            new Person(32, "Leland Mccaslin"),
            new Person(33, "Sanjuanita Slemp"),
            new Person(34, "Elwanda Nasser"),
            new Person(35, "Melody Cockerham"),
            new Person(36, "Roseann Mcgillis"),
            new Person(37, "Jesse Sheffield"),
            new Person(38, "Lavona Dolloff"),
            new Person(39, "Raisa Holst"),
            new Person(40, "Regan Schoenberg"),
            new Person(41, "Gearldine Pettry"),
            new Person(42, "Ilene Mahr"),
            new Person(43, "Mitchell Rethman"),
            new Person(44, "Britney Riddell"),
            new Person(45, "Signe Shuman"),
            new Person(46, "Valery Solie"),
            new Person(47, "Sherril Portwood"),
            new Person(48, "Moshe Lirette"),
            new Person(49, "Renata Rael"),
            new Person(50, "Jefferey Brendel"),
            new Person(51, "Vallie Eidt"),
            new Person(52, "Nadia Wine"),
            new Person(53, "Neomi Mole"),
            new Person(54, "Jannette Gambrell"),
            new Person(55, "Tomika Graeber"),
            new Person(56, "Ricki Purdom"),
            new Person(57, "Martine Tetrault"),
            new Person(58, "Dorotha Dashiell"),
            new Person(59, "Shaunda Demko"),
            new Person(60, "Nereida Chisum"),
            new Person(61, "Joy Besaw"),
            new Person(62, "Bernardine Winebrenner"),
            new Person(63, "Omega Segawa"),
            new Person(64, "Patrina Morones"),
            new Person(65, "Buddy Sowell"),
            new Person(66, "Mahalia Landrum"),
            new Person(67, "Fleta Luft"),
            new Person(68, "Helen Le"),
            new Person(69, "Darlene Borton"),
            new Person(70, "Lai Lamont"),
            new Person(71, "Winona Lapan"),
            new Person(72, "Annie Romero"),
            new Person(73, "Samantha Crone"),
            new Person(74, "Tamela Weatherwax"),
            new Person(75, "Denyse Bosket"),
            new Person(76, "Margurite Estabrook"),
            new Person(77, "Sebastian Hassell"),
            new Person(78, "Joshua Brittingham"),
            new Person(79, "Clay Hudspeth"),
            new Person(80, "Loriann Burditt"),
            new Person(81, "Keshia Poplawski"),
            new Person(82, "Karissa Paugh"),
            new Person(83, "Annamarie Drees"),
            new Person(84, "Tifany Johnosn"),
            new Person(85, "Essie Critchfield"),
            new Person(86, "Eleanore Bradeen"),
            new Person(87, "Deidre Chauez"),
            new Person(88, "Santo Limbaugh"),
            new Person(89, "Fermina Spinelli"),
            new Person(90, "Deonna Higby"),
            new Person(91, "Ute Fouts"),
            new Person(92, "Joesph Speno"),
            new Person(93, "Timothy Fritz"),
            new Person(94, "Irene Houze"),
            new Person(95, "Brock Lambright"),
            new Person(96, "Buffy Claybrooks"),
            new Person(97, "Jarod Hofstetter"),
            new Person(98, "Holley Mousseau"),
            new Person(99, "Bettye Soderberg"),
            new Person(100, "Tammera Strebel")
        };

        #endregion
    }
}
