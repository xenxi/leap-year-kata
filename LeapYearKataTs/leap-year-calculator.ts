export class LeapYearCalculator {
  public static isLeap(year: number): boolean {
    if (
      this.isDivisible({ year: year, num: 100 }) &&
      !this.isDivisible({ year: year, num: 400 })
    )
      return false;
    if (!this.isDivisible({ year: year, num: 4 })) return false;
    return true;
  }
  private static isDivisible = (params: {
    year: number;
    num: number;
  }): boolean => params.year % params.num == 0;
}
