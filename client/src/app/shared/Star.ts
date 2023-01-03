import { ApiEntity } from "./BaseEntity";

export interface Star extends ApiEntity {
    personId: string;
    postId?: string;
    commentId?: string;
}
