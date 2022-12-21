import { BaseEntity } from "./BaseEntity";

export interface Star extends BaseEntity {
    personId: string;
    postId?: string;
    commentId?: string;
}
