import { ApiEntity } from "./BaseEntity";

export interface Post extends ApiEntity {
    title: string;
    content: string;
    locked?: boolean;
    categoryId: string;
}