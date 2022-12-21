import { BaseEntity } from "./BaseEntity";

export interface UserRole extends BaseEntity {
    personId: string;
    postId?: string;
    commentId?: string;
}