export interface TaskItem{
    id: number;
    parentId: number;
    title: string;
    shortDescription: string;
    dueDate: Date;
    minutesSpent: number;
    minutesEstimated: number;
    assignedUserId: number;
    isDeleting: boolean;
}