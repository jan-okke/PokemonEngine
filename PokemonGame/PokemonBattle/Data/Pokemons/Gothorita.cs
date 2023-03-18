using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gothorita : Pokemon
	{
		public override string Name => "Gothorita";
		public override List<Ability> AvailableAbilities => new() {new Frisk(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Shadowtag() };
		public override Stats BaseStats => new Stats(60, 45, 70, 55, 75, 85);
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
			[46] = new List<Move>() { new Flatter() },
			[52] = new List<Move>() { new Futuresight() },
			[58] = new List<Move>() { new Magicroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Calmmind(), new Charm(), new Darkpulse(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Fling(), new Foulplay(), new Futuresight(), new Grassknot(), new Guardswap(), new Helpinghand(), new Hiddenpower(), new Lightscreen(), new Magicroom(), new Nastyplot(), new Payback(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Taunt(), new Thief(), new Thunderbolt(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Zenheadbutt() };
		public override int Weight => 180;
		public override int ExpYield => 137;
		public override int CatchRate => 100;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}