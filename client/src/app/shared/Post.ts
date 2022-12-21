import { BaseEntity } from "./BaseEntity";

export interface Post extends BaseEntity {
    title: string;
    content: string;
    locked?: boolean;
    categoryId: string;
}