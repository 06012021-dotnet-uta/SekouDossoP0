export interface FirstComponentInterface {
  id: number;
  name: string;
}

export interface StringValidation{
  isAcceptable(s:string): boolean;
}
