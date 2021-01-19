export class ShowModel {
    public constructor(
        public id?: number,
        public url?: string,
        public rating?: Rating,
        public image?: Image,
        public name?: string,
        public officialSite?: string
    ){}
}
export class Rating{
    public constructor(
        public average?: string
    ){}
}
export class Image{
    public constructor(
        public medium?: string,
        public original?: string
    ){}
}
