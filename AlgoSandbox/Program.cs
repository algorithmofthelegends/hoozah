﻿using System.Globalization;

var first = Console.ReadLine()?.ToCharArray()[0];
var middle = Console.ReadLine()?.ToCharArray()[0];
var last = Console.ReadLine()?.ToCharArray();

var m = first switch
{
    'ㄱ' => 0,
    'ㄲ' => 1,
    'ㄴ' => 2,
    'ㄷ' => 3,
    'ㄸ' => 4,
    'ㄹ' => 5,
    'ㅁ' => 6,
    'ㅂ' => 7,
    'ㅃ' => 8,
    'ㅅ' => 9,
    'ㅆ' => 10,
    'ㅇ' => 11,
    'ㅈ' => 12,
    'ㅉ' => 13,
    'ㅊ' => 14,
    'ㅋ' => 15,
    'ㅌ' => 16,
    'ㅍ' => 17,
    'ㅎ' => 18
};

var n = (int)middle - 12623;
var l = 0;
if(last.Length > 0)
{
    l = last[0] switch
    {
        'ㄱ' => 1,
        'ㄲ' => 2,
        'ㄳ' => 3,
        'ㄴ' => 4,
        'ㄵ' => 5,
        'ㄶ' => 6,
        'ㄷ' => 7,
        'ㄹ' => 8,
        'ㄺ' => 9,
        'ㄻ' => 10,
        'ㄼ' => 11,
        'ㄽ' => 12,
        'ㄾ' => 13,
        'ㄿ' => 14,
        'ㅀ' => 15,
        'ㅁ' => 16,
        'ㅂ' => 17,
        'ㅄ' => 18,
        'ㅅ' => 19,
        'ㅆ' => 20,
        'ㅇ' => 21,
        'ㅈ' => 22,
        'ㅊ' => 23,
        'ㅋ' => 24,
        'ㅌ' => 25,
        'ㅍ' => 26,
        'ㅎ' => 27
    };
}
Console.WriteLine((char)Convert.ToInt32(((m * 588) + (n * 28) + l + 44032).ToString("X"), 16));
 