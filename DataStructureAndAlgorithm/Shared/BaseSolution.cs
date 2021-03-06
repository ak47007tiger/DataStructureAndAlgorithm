using System;
using System.Collections.Generic;
using System.Text;
using DataStructure.Toolkit;

namespace DataStructure {

  public class BaseSolution {
    static Random random = new Random((int)(System.DateTime.Now.Ticks >> 5));
    public static int[] RandomData(int count) {
      var data = new int[count];
      for (var i = 0; i < count; i++) {
        data[i] = random.Next(count);
      }
      return data;
    }

    public static void print<T>(T t) {
      Printer.print(t);
    }

    public static void println(params object[] objs) {
      print(objs);
      Printer.print('\n');
    }

    public static void printComma(params object[] objs){
      print(objs);
      Printer.print(',');
    }

    public static void printArray<T>(params T[] array) {
      Printer.printArray(array);
    }

    public static void printIEnumerable<T>(IEnumerable<T> enumerable) {
      Printer.printEnumerable(enumerable);
    }

    public static void printFormat(string format, params object[] objs) {
      Printer.printFromat(format, objs);
    }

    public static void print(params object[] objs) {
      if(objs == null || objs.Length == 0) return;

      var sbd = new StringBuilder();
      for (var i = 0; i < objs.Length - 1; i++) {
        sbd.Append(objs[i].ToString()).Append(',');
      }
      sbd.Append(objs[objs.Length - 1]);
      print(sbd.ToString());
    }

  }
}