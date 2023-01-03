import { ApiEntity } from "./BaseEntity";

export interface UserRole extends ApiEntity {
    personId: string;
    postId?: string;
    commentId?: string;
}