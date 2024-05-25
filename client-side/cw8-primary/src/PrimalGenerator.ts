export default class PrimalGenerator {
    private limit: number;
    public constructor(limit: number = 20) {
        this.limit = limit;
    }
    public isPrimal(data: number): boolean {
        if (data < 2) return false;
        for (let i = 2; i * i <= data; i++) {
            if (data % i === 0) return false;
        }
        return true;
    }
    //napisac metode zwracajaca array liczb pierwszych o rozmiarze
    //limit
    public getPrimals(): number[] {
        const numbers: number[] = [];
        let current = 2;
        while (numbers.length < this.limit) {
            if (this.isPrimal(current)) {
                numbers.push(current)
            }
            current++
        }
        return numbers;
    }
}