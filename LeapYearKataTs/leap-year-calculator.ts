export class LeapYearCalculator {
  constructor(private year: number) {}

  public static isLeap(yearNumber: number): boolean {
    const year = new LeapYearCalculator(yearNumber);
    return year.isLeap();
  }

  public isLeap(): boolean {
    if (this.isDivisibleBy(100) && !this.isDivisibleBy(400)) return false;
    if (!this.isDivisibleBy(4)) return false;
    return true;
  }
  private isDivisibleBy = (num: number): boolean => this.year % num == 0;
}
