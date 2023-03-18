using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Spinda : Pokemon
	{
		public override string Name => "Spinda";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Tangledfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Contrary() };
		public override Stats BaseStats => new Stats(60, 60, 60, 60, 60, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[5] = new List<Move>() { new Copycat() },
			[10] = new List<Move>() { new Teeterdance() },
			[14] = new List<Move>() { new Psybeam() },
			[19] = new List<Move>() { new Hypnosis() },
			[23] = new List<Move>() { new Bodyslam() },
			[28] = new List<Move>() { new Suckerpunch() },
			[32] = new List<Move>() { new Teeterdance() },
			[37] = new List<Move>() { new Uproar() },
			[41] = new List<Move>() { new Psychup() },
			[46] = new List<Move>() { new Doubleedge() },
			[50] = new List<Move>() { new Flail() },
			[55] = new List<Move>() { new Thrash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Brickbreak(), new Calmmind(), new Confide(), new Covet(), new Dig(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focuspunch(), new Frustration(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icepunch(), new Icywind(), new Lastresort(), new Lowkick(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunderpunch(), new Trick(), new Trickroom(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Batonpass(), new Disable(), new Encore(), new Fakeout(), new Faketears(), new Guardsplit(), new Icywind(), new Psychocut(), new Psychoshift(), new Rapidspin(), new Roleplay(), new Trick(), new Wish() };
		public override int Weight => 50;
		public override int ExpYield => 126;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}