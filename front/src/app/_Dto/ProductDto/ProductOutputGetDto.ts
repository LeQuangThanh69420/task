export class ProductOutputGetDto {
    productId: number;
    productName: string;
    status: boolean;
    dateIn: Date;
    dateOut: Date;
    quantity: number;
    constructor() {
    }
}