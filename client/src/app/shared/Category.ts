import { ApiEntity } from "./BaseEntity";

export interface Category extends ApiEntity {
    title: string;
    description: string;
    forumCreator?: string;
}