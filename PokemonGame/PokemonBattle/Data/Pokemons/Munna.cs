using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Munna : Pokemon
	{
		public override string Name => "Munna";
		public override List<Ability> AvailableAbilities => new() {new Forewarn(), new Synchronize() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Telepathy() };
		public override Stats BaseStats => new Stats(76, 25, 45, 24, 67, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Storedpower(), new Defensecurl() },
			[4] = new List<Move>() { new Hypnosis() },
			[8] = new List<Move>() { new Psybeam() },
			[12] = new List<Move>() { new Imprison() },
			[16] = new List<Move>() { new Moonlight() },
			[20] = new List<Move>() { new Magiccoat() },
			[24] = new List<Move>() { new Zenheadbutt() },
			[28] = new List<Move>() { new Calmmind() },
			[32] = new List<Move>() { new Yawn() },
			[36] = new List<Move>() { new Psychic() },
			[40] = new List<Move>() { new Moonblast() },
			[44] = new List<Move>() { new Dreameater() },
			[48] = new List<Move>() { new Futuresight() },
			[52] = new List<Move>() { new Wonderroom() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Amnesia(), new Attract(), new Calmmind(), new Dazzlinggleam(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Futuresight(), new Guardswap(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Imprison(), new Lightscreen(), new Powerswap(), new Protect(), new Psychic(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Storedpower(), new Substitute(), new Swift(), new Thunderwave(), new Trick(), new Trickroom(), new Wonderroom(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Healingwish() };
		public override int Weight => 233;
		public override int ExpYield => 58;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}