export class LeapYearCalculator {
  public static isLeap(year: number): boolean {
    if (year % 4 !== 0) return false;
    return true;
  }
}
