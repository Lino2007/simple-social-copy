import { BaseEntity } from "./BaseEntity";

export interface Category extends BaseEntity {
    title: string;
    description: string;
    forumCreator?: string;
}