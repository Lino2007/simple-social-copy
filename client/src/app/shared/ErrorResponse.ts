export interface ErrorResponse {
    type: string,
    title: string,
    detail: string,
    instance?: string,
    balance?: number,
    accounts?: string[],
    status: number,
    traceId?: string
}