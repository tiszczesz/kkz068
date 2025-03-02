import React from 'react'

type Props = {
    content: string;
    limit?: number;
}

const MyText = (props: Props) => {
    const myLimit = props.limit || 10
    return (
        <div
            style={{ color: props.content.length <= myLimit ? "green" : "red" }}
        >
            {props.content}
        </div>
    )
}

export default MyText