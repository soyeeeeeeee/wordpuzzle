using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm
{
    class Program
    {
        static string[,] map =
        {
            {"■","□", "■", "■", "■", "■"},
            {"■","하", "□", "니", "카", "■"},
            {"■","산", "■", "■", "■", "■"},
            {"■","■", "■", "강", "■", "■"},
            {"■","■", "피", "□", "□", "■"},
            {"■","■", "■", "지", "■", "■"},
        };

        static string[,] normal =
        {
            {"■","트", "□", "우", "마", "■", "□"},
            {"■","■", "텍", "■", "■", "□", "화"},
            {"■","에", "□", "□", "모", "■", "■"},
            {"■","■", "■", "■", "■", "■", "■"},
            {"■","■", "■", "□", "■", "■", "■"},
            {"■","기", "□", "종", "이", "■", "■"},
            {"■","■", "■", "■", "■", "■", "■"}
        };

        static string[,] hard =
        {
            {"■","한", "□", "■", "□", "백", "■", "■"},
            {"■","■", "숭", "■", "■", "□", "□", "■"},
            {"■","송", "□", "□", "■", "몽", "■", "■"},
            {"■","□", "■", "■", "■", "■", "■", "■"},
            {"■","버", "□", "■", "□", "백", "질", "■"},
            {"■","섯", "■", "□", "□", "■", "□", "□"},
            {"■","■", "■", "■", "■", "■", "■", "■"},
            {"■","■", "■", "■", "■", "■", "■", "■"}
        };

        static void ShowMap(string[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                }
                Console.WriteLine();
            }
        }

        //메인 게임
        static void Main(string[] args)
        {//easy단계
            static void ShowMap()
            {
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            //normal단계 
            static void ShowMapNormal()
            {
                for (int x = 0; x < 7; x++)
                {
                    for (int y = 0; y < 7; y++)
                    {
                        Console.Write(normal[x, y]);
                    }
                    Console.WriteLine();
                }
            }

            //hard단계
            static void ShowMapHard()
            {
                for (int r = 0; r < 8; r++)
                {
                    for (int t = 0; t < 8; t++)
                    {
                        Console.Write(hard[r, t]);
                    }
                    Console.WriteLine();
                }
            }
            static void showBoard()
            {
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□■□□□□■□□□■■■■□■□□□■■■■■□□■□□■■■■■□□□□□□□");
                Console.WriteLine("□□■□□□□■■■□■□□■□■■■□□□□□■□□■□□□□□□■□□□□□□□");
                Console.WriteLine("□□■□□□□■□□□■□□■□■□□□■■■■■□□■□□□□□■□□□□□□□□");
                Console.WriteLine("□□■■■■□■□□□■■■■□■□□□□□□□■□□■□□□□■□■□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□■□□□■□□□■□□□□□□");
                Console.WriteLine("□□□□■■■■□□□□□■■■■□□□■■■■■■□■□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□■□□□□□□□□□□□■□□□□□□■□□□■□□■■■■■■■□□□□□");
                Console.WriteLine("□□□□■■■■□□□□□■■■■□□□□□□■□□□■□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□■□□□□□□□□■□□□□□□□□□■□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□■■■■□□□□□■■■■□□□□□□■□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
                Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");

                Console.WriteLine("난이도를 선택하세요");
                Console.Write("easy(0)          ");
                Console.Write("normal(1)          ");
                Console.Write("hard(2)          ");
            }
            showBoard();
            string selectedDifficulty = Console.ReadLine();


            //이지모드
            string[] arr_dap = new string[4] { "낙", "모", "아", "노" };
            string[] arr_mun = new string[4]
            {
                "세로1: 비행 중인 항공기 따위에서 사람이나 물건을 안전하게 땅 위에 내리도록 하는 데 쓰는 기구. [□하산]",
                "가로1: 직사각형의 틀에 조그마한 칸을 여러 개 만들고, 칸마다 쇠붙이 서를 끼워 만든 작은 관악기. 입에 대고 숨을 불어 넣거나 빨아들여서 소리를 낸다. [하□니카]",
                "세로2: 개의 새끼. [강□지]",
                "가로2: 큰 공명 상자 속에 85개 이상의 금속 현을 치고, 이와 연결된 건반을 눌러서 현을 때리게 하는 장치로 소리를 내는 건반 악기. [피아□]",

            };

            int[] arr_i = new int[4] { 0, 1, 4, 4 };
            int[] arr_j = new int[4] { 1, 2, 3, 4 };


            //노말모드
            string[] arr_dapx = new string[7] { "라", "스", "키", "동", "벽", "멸", "름" };
            string[] arr_muny = new string[7]
            {
                "가로1: 심리 쇼크, 정신적 충격, 마음의 상처. [트□우마]",
                "세로1: 고무나무에서 채취한 원료에 황을 섞어 탄력이 있게 만든 고무. [라텍□]",
                "가로2: 북극, 캐나다, 그린란드 및 시베리아의 북극 지방에 사는 인종. [에스□모]",
                "세로2: 어린이를 위하여 동심(童心)을 바탕으로 지은 이야기. [□화]",
                "가로3: 건물이나 동굴, 무덤 따위의 벽에 그린 그림. [□화]",
                "세로3: 생물의 한 종류가 아주 없어짐. [□종]",
                "가로4: 얼굴 따위의 기름기를 제거하는 데에 쓰는 종이. [기□종이]",
            };

            int[] arr_x = new int[7] { 0, 2, 2, 0, 1, 4, 5 };
            int[] arr_y = new int[7] { 2, 2, 3, 6, 5, 3, 2 };


            //하드
            string[] arr_dapt = new string[13] { "복", "아", "지", "이", "공", "일", "출", "선", "소", "단", "어", "붕", "금" };
            string[] arr_munr = new string[13]
            {
                "가로1: 조선 시대에 입던 형태의 옷. [한□]",
                "세로1: 복사나무의 열매. 품종에 따라 크고 작은 것이 있는데, 시고 단 맛이 있으며 담홍색으로 익는다. [복숭□]",
                "가로2: 어린 소. [송아□]",
                "세로2: 송이과의 버섯. 갓은 지름이 8~20cm이고 겉은 엷은 다갈색, 살은 흰색이다. 독특한 향기와 맛을 지닌 대표적인 식용 버섯이다. [송□버섯]",
                "가로3: 아무것도 없이 비어 있음. [□백]",
                "세로3: 대낮에 꿈을 꾼다는 뜻으로, 실현될 수 없는 헛된 공상을 이르는 말. [백□몽]",
                "가로4: 해가 뜸. [일□]",
                "가로5: 천으로 발 모양과 비슷하게 만들어 종아리 아래까지 발에 신는 물건. [버□]",
                "세로5: 공기의 약 5분의 4를 차지하는 무색ㆍ무미ㆍ무취의 기체 질소 분자를 이루는 원소. [질□]",
                "가로6: 아미노산이 펩타이드 결합을 하여 생긴 여러 개의 아미노산으로 이루어진 고분자 화합물. [□백질]",
                "세로6: 분리하여 자립적으로 쓸 수 있는 말이나 이에 준하는 말. 또는 그 말의 뒤에 붙어서 문법적 기능을 나타내는 말. [단□]",
                "가로7: 잉엇과의 민물고기. 몸의 길이는 20~43cm이며, 등은 푸른 갈색이고 배 쪽은 누르스름한 은백색이다. [□어]",
                "가로8: 짠맛이 나는 백색의 결정체. 대표적인 조미료로, 주성분은 염화 나트륨이다. [소□]",
            };

            int[] arr_r = new int[13] { 0, 2, 2, 3, 0, 1, 1, 4, 5, 4, 5, 5, 5 };
            int[] arr_t = new int[13] { 2, 2, 3, 1, 4, 5, 6, 2, 6, 4, 4, 3, 7 };

            //세로1

            while (true)
            {
                try
                {
                    if (selectedDifficulty == "0") //easy
                    {

                        Console.Clear();
                        Console.WriteLine("easy난이도를 선택하셨습니다.");
                        Console.WriteLine();
                        ShowMap();


                        int step = 0;

                        while (step < arr_mun.Length)
                        {
                            string mun = arr_mun[step]; //문제
                            string dap = arr_dap[step]; //답
                            int m_i = arr_i[step];
                            int m_j = arr_j[step];

                            Console.WriteLine();
                            Console.WriteLine("<힌트>");
                            Console.WriteLine(mun);
                            Console.WriteLine();

                            string str = Console.ReadLine();
                            if (str == dap)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("맞추었습니다.");
                                map[m_i, m_j] = dap;
                                Console.WriteLine();

                                step++;
                                if (step == arr_dap.Length)
                                {
                                    ShowMap();
                                    Console.WriteLine();
                                    Console.WriteLine("easy 모드 클리어!!!");

                                    // 사용자에게 다음 동작을 선택하도록 유도
                                    Console.WriteLine("다음 모드로 이동하려면 8을 누르세요. 게임을 종료하려면 9를 누르세요:");
                                    string userInput = Console.ReadLine();

                                    if (userInput == "8")
                                    {
                                        selectedDifficulty = "1"; // 노멀 모드로 이동
                                        continue;
                                    }
                                    else if (userInput == "9")
                                    {
                                        Console.Clear() ;
                                        Console.WriteLine("게임을 종료합니다.");
                                        return;
                                    }

                                }
                                Console.Clear();
                                mun = arr_mun[step];
                                dap = arr_dap[step];
                                m_i = arr_i[step];
                                m_j = arr_j[step];

                                ShowMap();


                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("틀렸습니다.");
                                Console.WriteLine();
                                ShowMap();
                            }
                        }
                    }
                    else if (selectedDifficulty == "1")  //normal
                    {
                        Console.Clear();
                        Console.WriteLine("normal난이도를 선택하셨습니다.");
                        Console.WriteLine();
                        ShowMapNormal();

                        int step = 0;
                        

                        while (step < arr_muny.Length)
                        {
                            string muny = arr_muny[step];
                            string dapx = arr_dapx[step];
                            int m_x = arr_x[step];
                            int m_y = arr_y[step];

                            Console.WriteLine();
                            Console.WriteLine("<힌트>");
                            Console.WriteLine(muny);
                            Console.WriteLine();

                            string str = Console.ReadLine();
                            if (str == dapx)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("맞추었습니다.");
                                normal[m_x, m_y] = dapx;
                                Console.WriteLine();

                                step++;
                                if (step == arr_dapx.Length)
                                {
                                    ShowMapNormal();
                                    Console.WriteLine();
                                    Console.WriteLine("normal 모드 클리어!!!");

                                    // 사용자에게 다음 동작을 선택하도록 유도
                                    Console.WriteLine("다음 모드로 이동하려면 8을 누르세요. 게임을 종료하려면 9를 누르세요:");
                                    string userInput = Console.ReadLine();

                                    if (userInput == "8")
                                    {
                                        selectedDifficulty = "2"; // 노멀 모드로 이동
                                        continue;
                                    }
                                    else if (userInput == "9")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("게임을 종료합니다.");
                                        return;
                                    }

                                }
                                Console.Clear();
                                muny = arr_muny[step];
                                dapx = arr_dapx[step];
                                m_x = arr_x[step];
                                m_y = arr_y[step];

                                ShowMapNormal();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("틀렸습니다.");
                                Console.WriteLine();
                                ShowMapNormal();
                            }

                        }

                    }
                    else if (selectedDifficulty == "2")  //hard
                    {
                        Console.Clear();
                        Console.WriteLine("hard난이도를 선택하셨습니다.");
                        Console.WriteLine();
                        ShowMapHard();

                        int step = 0;
                        


                        while (step < arr_munr.Length)
                        {
                            string munr = arr_munr[step];
                            string dapt = arr_dapt[step];
                            int m_r = arr_r[step];
                            int m_t = arr_t[step];

                            Console.WriteLine();
                            Console.WriteLine("<힌트>");
                            Console.WriteLine(munr);
                            Console.WriteLine();

                            string str = Console.ReadLine();
                            if (str == dapt)
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("맞추었습니다.");
                                hard[m_r, m_t] = dapt;
                                Console.WriteLine();

                                step++;
                                if (step == arr_dapt.Length)
                                {
                                    ShowMapHard();
                                    Console.WriteLine();
                                    Console.WriteLine("hard 모드 클리어!!!");

                                    // 사용자에게 다음 동작을 선택하도록 유도
                                    Console.WriteLine("게임을 종료하려면 엔터를 누르세요");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Console.WriteLine("게임을 종료합니다.");
                                    return;
                                }
                                Console.Clear();
                                munr = arr_munr[step];
                                dapt = arr_dapt[step];
                                m_r = arr_r[step];
                                m_t = arr_t[step];

                                ShowMapHard();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("틀렸습니다.");
                                Console.WriteLine();
                                ShowMapHard();
                            }


                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("올바른 난이도를 선택하세요 (0, 1, 2).");
                        showBoard();
                        selectedDifficulty = Console.ReadLine();
                        continue;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("게임종료");
                    break;
                }
            }
        }
    }
}
