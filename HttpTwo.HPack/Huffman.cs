﻿/*
 * Copyright 2015 Ringo Leese
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
namespace HttpTwo.HPack
{
    public class Huffman
    {
        /// <summary>
        /// Huffman Decoder
        /// </summary>
        public static HuffmanDecoder DECODER = new HuffmanDecoder(HPackUtil.HUFFMAN_CODES, HPackUtil.HUFFMAN_CODE_LENGTHS);

        /// <summary>
        /// Huffman Encoder
        /// </summary>
        public static HuffmanEncoder ENCODER = new HuffmanEncoder(HPackUtil.HUFFMAN_CODES, HPackUtil.HUFFMAN_CODE_LENGTHS);

        private Huffman()
        {
            // utility class
        }
    }
}