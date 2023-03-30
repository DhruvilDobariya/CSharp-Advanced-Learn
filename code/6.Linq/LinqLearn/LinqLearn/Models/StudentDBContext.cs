using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqLearn.Models
{
    public class StudentDBContext
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student(){
              Id =  1,
              Name =  "Gibb",
              Age =  20
            },
            new Student(){
              Id =  2,
              Name =  "Jillie",
              Age =  56
            },
            new Student(){
              Id =  3,
              Name =  "Fairlie",
              Age =  9
            },
            new Student(){
              Id =  4,
              Name =  "Dorette",
              Age =  12
            },
            new Student(){
              Id =  5,
              Name =  "Rennie",
              Age =  7
            },
            new Student(){
              Id =  6,
              Name =  "Jaynell",
              Age =  3
            },
            new Student(){
              Id =  7,
              Name =  "Dael",
              Age =  39
            },
            new Student(){
              Id =  8,
              Name =  "Gloriane",
              Age =  90
            },
            new Student(){
              Id =  9,
              Name =  "Eldredge",
              Age =  15
            },
            new Student(){
              Id =  10,
              Name =  "Eleanore",
              Age =  60
            },
            new Student(){
              Id =  11,
              Name =  "Lillian",
              Age =  32
            },
            new Student(){
              Id =  12,
              Name =  "Gaspard",
              Age =  44
            },
            new Student(){
              Id =  13,
              Name =  "Audry",
              Age =  15
            },
            new Student(){
              Id =  14,
              Name =  "Lurlene",
              Age =  6
            },
            new Student(){
              Id =  15,
              Name =  "Xymenes",
              Age =  4
            },
            new Student(){
              Id =  16,
              Name =  "Brittan",
              Age =  33
            },
            new Student(){
              Id =  17,
              Name =  "Lilah",
              Age =  58
            },
            new Student(){
              Id =  18,
              Name =  "Berri",
              Age =  3
            },
            new Student(){
              Id =  19,
              Name =  "Melisande",
              Age =  11
            },
            new Student(){
              Id =  20,
              Name =  "Avivah",
              Age =  90
            },
            new Student(){
              Id =  21,
              Name =  "Kendell",
              Age =  92
            },
            new Student(){
              Id =  22,
              Name =  "Michaela",
              Age =  90
            },
            new Student(){
              Id =  23,
              Name =  "Francene",
              Age =  55
            },
            new Student(){
              Id =  24,
              Name =  "Meggy",
              Age =  56
            },
            new Student(){
              Id =  25,
              Name =  "Pauly",
              Age =  15
            },
            new Student(){
              Id =  26,
              Name =  "Lion",
              Age =  7
            },
            new Student(){
              Id =  27,
              Name =  "Devin",
              Age =  57
            },
            new Student(){
              Id =  28,
              Name =  "Stephine",
              Age =  10
            },
            new Student(){
              Id =  29,
              Name =  "Ahmad",
              Age =  13
            },
            new Student(){
              Id =  30,
              Name =  "Thorny",
              Age =  32
            },
            new Student(){
              Id =  31,
              Name =  "Alan",
              Age =  78
            },
            new Student(){
              Id =  32,
              Name =  "Glen",
              Age =  74
            },
            new Student(){
              Id =  33,
              Name =  "Sherri",
              Age =  16
            },
            new Student(){
              Id =  34,
              Name =  "Kare",
              Age =  1
            },
            new Student(){
              Id =  35,
              Name =  "Lulita",
              Age =  28
            },
            new Student(){
              Id =  36,
              Name =  "Rogers",
              Age =  51
            },
            new Student(){
              Id =  37,
              Name =  "Stavros",
              Age =  34
            },
            new Student(){
              Id =  38,
              Name =  "Yolane",
              Age =  83
            },
            new Student(){
              Id =  39,
              Name =  "Benedetto",
              Age =  74
            },
            new Student(){
              Id =  40,
              Name =  "Emelen",
              Age =  26
            },
            new Student(){
              Id =  41,
              Name =  "Stepha",
              Age =  8
            },
            new Student(){
              Id =  42,
              Name =  "Lexine",
              Age =  70
            },
            new Student(){
              Id =  43,
              Name =  "Alica",
              Age =  53
            },
            new Student(){
              Id =  44,
              Name =  "Kenyon",
              Age =  51
            },
            new Student(){
              Id =  45,
              Name =  "Ellerey",
              Age =  20
            },
            new Student(){
              Id =  46,
              Name =  "Winona",
              Age =  47
            },
            new Student(){
              Id =  47,
              Name =  "Katee",
              Age =  89
            },
            new Student(){
              Id =  48,
              Name =  "Jammie",
              Age =  66
            },
            new Student(){
              Id =  49,
              Name =  "Godart",
              Age =  85
            },
            new Student(){
              Id =  50,
              Name =  "Gaspard",
              Age =  35
            },
            new Student(){
              Id =  51,
              Name =  "Inga",
              Age =  92
            },
            new Student(){
              Id =  52,
              Name =  "Marielle",
              Age =  12
            },
            new Student(){
              Id =  53,
              Name =  "Stevy",
              Age =  10
            },
            new Student(){
              Id =  54,
              Name =  "Dominik",
              Age =  22
            },
            new Student(){
              Id =  55,
              Name =  "Sandy",
              Age =  18
            },
            new Student(){
              Id =  56,
              Name =  "Calhoun",
              Age =  53
            },
            new Student(){
              Id =  57,
              Name =  "August",
              Age =  86
            },
            new Student(){
              Id =  58,
              Name =  "Ilene",
              Age =  2
            },
            new Student(){
              Id =  59,
              Name =  "Opaline",
              Age =  68
            },
            new Student(){
              Id =  60,
              Name =  "Fraser",
              Age =  72
            },
            new Student(){
              Id =  61,
              Name =  "Meggy",
              Age =  93
            },
            new Student(){
              Id =  62,
              Name =  "Steffane",
              Age =  82
            },
            new Student(){
              Id =  63,
              Name =  "Kyle",
              Age =  46
            },
            new Student(){
              Id =  64,
              Name =  "Junina",
              Age =  78
            },
            new Student(){
              Id =  65,
              Name =  "Shell",
              Age =  38
            },
            new Student(){
              Id =  66,
              Name =  "Ava",
              Age =  80
            },
            new Student(){
              Id =  67,
              Name =  "Kizzee",
              Age =  62
            },
            new Student(){
              Id =  68,
              Name =  "Rena",
              Age =  16
            },
            new Student(){
              Id =  69,
              Name =  "Dalis",
              Age =  22
            },
            new Student(){
              Id =  70,
              Name =  "Hamil",
              Age =  53
            },
            new Student(){
              Id =  71,
              Name =  "Tove",
              Age =  41
            },
            new Student(){
              Id =  72,
              Name =  "Reilly",
              Age =  16
            },
            new Student(){
              Id =  73,
              Name =  "Karia",
              Age =  74
            },
            new Student(){
              Id =  74,
              Name =  "Amerigo",
              Age =  58
            },
            new Student(){
              Id =  75,
              Name =  "Chantal",
              Age =  88
            },
            new Student(){
              Id =  76,
              Name =  "Clayborn",
              Age =  36
            },
            new Student(){
              Id =  77,
              Name =  "Weidar",
              Age =  15
            },
            new Student(){
              Id =  78,
              Name =  "Lexi",
              Age =  32
            },
            new Student(){
              Id =  79,
              Name =  "Cosimo",
              Age =  4
            },
            new Student(){
              Id =  80,
              Name =  "Magdaia",
              Age =  93
            },
            new Student(){
              Id =  81,
              Name =  "Deny",
              Age =  34
            },
            new Student(){
              Id =  82,
              Name =  "Baldwin",
              Age =  37
            },
            new Student(){
              Id =  83,
              Name =  "Viviana",
              Age =  48
            },
            new Student(){
              Id =  84,
              Name =  "Brigham",
              Age =  58
            },
            new Student(){
              Id =  85,
              Name =  "Manda",
              Age =  55
            },
            new Student(){
              Id =  86,
              Name =  "Gnni",
              Age =  18
            },
            new Student(){
              Id =  87,
              Name =  "Ara",
              Age =  24
            },
            new Student(){
              Id =  88,
              Name =  "Silvester",
              Age =  23
            },
            new Student(){
              Id =  89,
              Name =  "Lana",
              Age =  98
            },
            new Student(){
              Id =  90,
              Name =  "Lowe",
              Age =  60
            },
            new Student(){
              Id =  91,
              Name =  "Berke",
              Age =  66
            },
            new Student(){
              Id =  92,
              Name =  "Wallis",
              Age =  78
            },
            new Student(){
              Id =  93,
              Name =  "Jacquetta",
              Age =  50
            },
            new Student(){
              Id =  94,
              Name =  "Leila",
              Age =  50
            },
            new Student(){
              Id =  95,
              Name =  "Lin",
              Age =  18
            },
            new Student(){
              Id =  96,
              Name =  "Worthington",
              Age =  16
            },
            new Student(){
              Id =  97,
              Name =  "Elsworth",
              Age =  23
            },
            new Student(){
              Id =  98,
              Name =  "Gordie",
              Age =  43
            },
            new Student(){
              Id =  99,
              Name =  "Lenna",
              Age =  20
            },
            new Student(){
              Id =  100,
              Name =  "Lilli",
              Age =  76
            }
        };

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
