C#언어를 이용해서 만든 이 가로세로 낱말퍼즐은 간단한 퍼즐 게임으로, 총 세 가지 난이도 (easy, normal, hard)로 구성되어 있습니다. 
한 난이도를 클리어한 플레이어는 다음 난이도로 이동하거나 게임을 종료할 수 있습니다.

함수와 메서드:
-ShowMap: 2차원 배열의 현재 상태를 화면에 출력하는 함수입니다. Console.Write와 Console.WriteLine을 사용하여 보드를 표시합니다.
-Main: 프로그램의 메인 진입점이며, 게임의 주요 로직을 포함하는 메서드입니다. 각 난이도에 따른 게임 진행, 힌트 제공, 플레이어 입력을 처리합니다.
-ShowMap, ShowMapNormal, ShowMapHard: 난이도에 따라 다른 2차원 배열을 출력하는 함수들입니다.

2차원 배열:
-map, normal, hard 배열은 게임 보드를 표현합니다. 각 배열은 문자열로 이루어진 격자로 구성되어 있고, ShowMap 함수를 통해 화면에 표시됩니다.

변수:
-selectedDifficulty: 사용자가 선택한 난이도를 나타내는 변수입니다. 사용자가 입력한 값을 저장하고, 난이도에 따라 게임의 흐름이 변합니다.
-userInput: 사용자로부터의 입력을 저장하는 변수로, 게임 종료 후 다음 동작을 선택할 때 사용됩니다.

배열:
-arr_dap, arr_mun: 쉬운 난이도에서 추측해야 할 단어와 각 단어에 대한 힌트를 저장하는 배열입니다. 인덱스를 통해 각 단어와 힌트에 접근합니다.
-arr_dapx, arr_muny: 중간 난이도에서 추측해야 할 단어와 각 단어에 대한 힌트를 저장하는 배열입니다.
-arr_dapt, arr_munr: 어려운 난이도에서 추측해야 할 단어와 각 단어에 대한 힌트를 저장하는 배열입니다.
