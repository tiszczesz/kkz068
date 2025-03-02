import React from 'react'

type Props = {
    title: string
    source: string[]
    listType: 'ul' | 'ol'
}

const StringsList = ({ title, source, listType }: Props) => {
  
    return (
        <>
            <h3>{title}</h3>
            {listType === 'ul' ? (
                <ul>
                    {source.map((item, index) => (
                        <li key={index}>{item}</li>
                    ))}
                </ul>
            ) : (
                <ol>
                    {source.map((item, index) => (
                        <li key={index}>{item}</li>
                    ))}
                </ol>
            )}
        </>
    )
}

export default StringsList