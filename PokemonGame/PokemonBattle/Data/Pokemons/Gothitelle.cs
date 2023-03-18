using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gothitelle : Pokemon
	{
		public override string Name => "Gothitelle";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shadowtag() };
		public override Stats BaseStats => new Stats(70, 55, 95, 95, 110, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Confusion(), new Playnice(), new Tickle() },
			[12] = new List<Move>() { new Psybeam() },
			[16] = new List<Move>() { new Charm() },
			[20] = new List<Move>() { new Psyshock() },
			[24] = new List<Move>() { new Hypnosis() },
			[28] = new List<Move>() { new Faketears() },
			[35] = new List<Move>() { new Psychup() },
			[40] = new List<Move>() { new Psychic() },
			[48] = new List<Move>() { new Flatter() },
			[56] = new List<Move>() { new Futuresight() },
			[64] = new List<Move>() { new Magicroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Brickbreak(), new Calmmind(), new Charm(), new Cosmicpower(), new Darkpulse(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Fling(), new Foulplay(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Lowsweep(), new Magicroom(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Zenheadbutt() };
		public override int Weight => 440;
		public override int ExpYield => 245;
		public override int CatchRate => 50;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}